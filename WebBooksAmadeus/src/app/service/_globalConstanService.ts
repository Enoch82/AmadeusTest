import { Injectable } from "@angular/core";
import { HttpHeaders } from '@angular/common/http';


@Injectable()
export class GlobalConstantService  {
  readonly baseAppUrl: string = 'https://localhost:44382/';
    readonly httpOptions = {
      headers: new HttpHeaders({
            'Content-Type': 'application/json'
        })
    }
}