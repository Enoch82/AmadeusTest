import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { CustomeResponse } from './interface/CustomeResponse';
import { Store } from './interface/Store';
import { BookService } from './service/book.service';
import { StoreService } from './service/store.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'WebBooksAmadeus';
  bookForm : FormGroup;
  storeList: Array<Store>;
  bookList;
  displayedColumns = [
    'title', 'publisher', 'price', 'store'
  ]
  constructor(private bookService: BookService,
              private storeService: StoreService,
              private fb: FormBuilder)
              {
  }

  ngOnInit(): void {
    this.getStoreList();
    this.getBookList();
    this.setBookForm();
    
  }
  async getStoreList(){
    let cr = <CustomeResponse> await this.storeService.storeList().toPromise();
    this.storeList = cr.data;
    console.log(cr)
  }
  async getBookList(){
    let cr = <CustomeResponse> await this.bookService.bookList().toPromise();
    this.bookList = cr.data;
  }
  setBookForm(){
    this.bookForm = this.fb.group({
        title : [],
        subtitle : [],
        authors : [],
        publisher : [],
        isbn10 : [],
        isbn13 : [],
        pages : [],
        year : [],
        decimal : [],
        description : [],
        price : [],
        urlImage : [],
        url : [],
    })
  }

  findStore(id){
    console.log(id)
    return this.storeList.find(s =>s.storeId == id).branchName
  }
}
