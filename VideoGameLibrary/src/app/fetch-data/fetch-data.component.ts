import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html',
  styleUrls: ['./fetch-data.component.css']
})
export class FetchDataComponent {
  public info: GameNames[] = [];
  baseUrl = 'https://localhost:7249/'

  constructor(http: HttpClient){
    http.get<GameNames[]>(this.baseUrl + 'api/Game').subscribe(result => {
      this.info = result;
    }, error => console.error(error));
  }
}


interface GameNames { 
  GameName : string;
  Publisher : string;
  Genre : string;
  GameRating : string;
  PercentComplete : number;

}
