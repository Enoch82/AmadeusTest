using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiBooksAmadeus.Repository;
using ApiBooksAmadeus.Model;

namespace ApiBooksAmadeus.Controllers
{
  
    [Route("[controller]")]
    public class StoreController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public StoreController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("[action]")]
        public CustomeResponse StoreList()
        {
            CustomeResponse cr = new CustomeResponse();
            try
            {
                var storeList = _unitOfWork.Store.GetAll();
                cr.Data = storeList;
            }catch(Exception ex)
            {
                cr.Message = ex.Message; 
            }
            
            return cr;
        }

        [HttpPatch("[action]")]
        public CustomeResponse EditStore([FromBody] StoreModel store)
        {
            CustomeResponse cr = new CustomeResponse();
            try
            {
                 _unitOfWork.Store.Update(store);
                cr.Data = _unitOfWork.Store.Find(s => s.storeId == store.storeId).First();
                cr.Success = 1;

            }
            catch (Exception ex)
            {
                cr.Message = ex.Message;
                cr.Success = 0;

            }

            return cr;
        }
        
        [HttpPost("[action]")]
        public CustomeResponse DeleteStore([FromBody] StoreModel store)
        {
            CustomeResponse cr = new CustomeResponse();
            try
            {
                _unitOfWork.Store.Delete(store);
                cr.Message = "The Store was deleted!";
                cr.Success = 1;

            }
            catch (Exception ex)
            {
                cr.Message = ex.Message;
                cr.Success = 0;
            }

            return cr;
        }

        [HttpPost("[action]")]
        public CustomeResponse CreateStore([FromBody] StoreModel store)
        {
            CustomeResponse cr = new CustomeResponse();
            try
            {
                _unitOfWork.Store.Save(store);
                cr.Data = _unitOfWork.Store.Find(s => s.branchName == store.branchName);
                cr.Message = "The Store was created!";
                cr.Success = 1;

            }
            catch (Exception ex)
            {
                cr.Message = ex.Message;
                cr.Success = 0;
            }

            return cr;
        }
    }
}
