import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any;

  constructor(private http: HttpClient) {

  }

  ngOnInit(): void {
    this.getEventos();
  }

  public getEventos() : void {
    this.http.get('https://localhost:7180/api/eventos').subscribe({
      next: (v) => this.eventos = v,
      error: (e) => console.log(e),
    }
    );

    // this.eventos = [
    //     {
    //       Tema: 'Angular 11',
    //       Local: 'Belo Horizonte'
    //     },
    //     {
    //       Tema: '.NET 5',
    //       Local: 'São Paulo'
    //     },
    //     {
    //       Tema: 'Angular e suas novidades',
    //       Local: 'Rio de Janeiro'
    //     }
    // ];
  }


}
