import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.css']
})
export class EventosComponent implements OnInit {

    public eventos: any = [
      {
        Tema: 'Angular',
        Local: 'Rio de Janeiro'
    },
    {
      Tema: 'Reuniao',
      Local: 'São Paulo'
    },
    {
      Tema: 'Reu',
      Local: 'DF'
    }
    ]  //importar o HttpClient
  constructor(private http:HttpClient) { }

  ngOnInit(): void {
    this.getEventos();
  }
  public getEventos ():void {
    this.http.get ('https://localhost:5001/api/Eventos').subscribe(
      response =>this.eventos = response,
      error => console.log (error));
  }

}
