import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  registerMode = false;
  trophies: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getTrophies();
  }

  registerToggle() {
    this.registerMode = true;
  }

  getTrophies() {
    this.http.get('http://localhost:5000/api/trophies').subscribe(response => {
      this.trophies = response;
    }, error => {
      console.log(error);
    });
  }

  cancelRegisterMode(registerMode: boolean) {
    this.registerMode = registerMode;
  }

}
