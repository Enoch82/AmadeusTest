import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Store } from '../interface/Store';
import { GlobalConstantService } from './_globalConstanService';

@Injectable({
  providedIn: 'root'
})
export class StoreService {

  constructor(private http: HttpClient,
    private globalConst: GlobalConstantService) { }

  saveStore(store: Store){
    let section = this.globalConst.baseAppUrl  +'Store/CreateStore';
    return this.http.post(section, JSON.stringify(store),this.globalConst.httpOptions)
  }
  editStore(store: Store){
    let section = this.globalConst.baseAppUrl  +'Store/EditStore';
    return this.http.patch(section, JSON.stringify(store),this.globalConst.httpOptions)
  }

  deleteStore(store: Store){
    let section = this.globalConst.baseAppUrl  +'Store/DeleteStore';
    return this.http.post(section, JSON.stringify(store),this.globalConst.httpOptions)
  }

  storeList(){
    let section = this.globalConst.baseAppUrl  +'Store/StoreList';
    return this.http.get(section)

  }


}
