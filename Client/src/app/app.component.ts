import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Console } from 'console';
import { response } from 'express';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  title = 'Dating App';
  users: any;

   constructor (private http: HttpClient) {}
  ngOnInit(): void {
    this.http.get('http://Localhost:5142/api/users').subscribe({
      next: response => this.users = response,
      error: (error: any) => console.log(error),
      complete: () => console.log('Resquest has completed'),
    })





  }




}
