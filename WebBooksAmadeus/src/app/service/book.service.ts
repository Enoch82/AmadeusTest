import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Book } from '../interface/Book';
import { Store } from '../interface/Store';
import { GlobalConstantService } from './_globalConstanService';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  constructor(private http: HttpClient,
              private globalConst: GlobalConstantService) { }

  saveBook(book: Book){
    let section = this.globalConst.baseAppUrl  +'Book/CreateBook';
    return this.http.post(section, JSON.stringify(book),this.globalConst.httpOptions)
  }
  editBook(book: Book){
    let section = this.globalConst.baseAppUrl  +'Book/EditBook';
    return this.http.patch(section, JSON.stringify(book),this.globalConst.httpOptions)
  }

  deleteBook(book: Book){
    let section = this.globalConst.baseAppUrl  +'Book/DeleteBook';
    return this.http.post(section, JSON.stringify(book),this.globalConst.httpOptions)
  }

  bookList(){
    let section = this.globalConst.baseAppUrl  +'Book/BookList';
    return this.http.get(section)

  }
}
