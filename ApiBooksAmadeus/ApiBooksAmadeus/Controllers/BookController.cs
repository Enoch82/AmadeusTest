using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiBooksAmadeus.Model;
using ApiBooksAmadeus.Repository;

namespace ApiBooksAmadeus.Controllers
{
    
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        //Listar Clientes

        public BookController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet("[action]")]
        public CustomeResponse BookList()
        {
            CustomeResponse cr = new CustomeResponse();
            try
            {
                var bookList = _unitOfWork.Book.GetAll();
                cr.Data = bookList;
            }
            catch (Exception ex)
            {
                cr.Message = ex.Message;
            }

            return cr;
        }

        [HttpPatch("[action]")]
        public CustomeResponse EditBook([FromBody] BookModel book)
        {
            CustomeResponse cr = new CustomeResponse();
            try
            {
                _unitOfWork.Book.Update(book);
                cr.Data = _unitOfWork.Book.Find(b => b.bookId == book.bookId).First();
                cr.Success = 1;

            }
            catch (Exception ex)
            {
                cr.Message = ex.Message;
                cr.Success = 0;

            }

            return cr;
        }

        [HttpDelete("[action]")]
        public CustomeResponse DeleteBook([FromBody] BookModel book)
        {
            CustomeResponse cr = new CustomeResponse();
            try
            {
                _unitOfWork.Book.Delete(book);
                cr.Message = "The Book was deleted!";
                cr.Success = 1;

            }
            catch (Exception ex)
            {
                cr.Message = ex.Message;
                cr.Success = 0;
            }

            return cr;
        }

        [HttpDelete("[action]")]
        public CustomeResponse CreateBook([FromBody] BookModel book)
        {
            CustomeResponse cr = new CustomeResponse();
            try
            {
                _unitOfWork.Book.Save(book);
                cr.Data = _unitOfWork.Book.Find(s => s.title == book.title);
                cr.Message = "The Book was created!";
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
