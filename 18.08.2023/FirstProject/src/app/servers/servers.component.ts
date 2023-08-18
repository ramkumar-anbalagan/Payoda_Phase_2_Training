import { Component } from '@angular/core';

@Component({
  selector: 'app-servers',
  templateUrl: './servers.component.html',
  styleUrls: ['./servers.component.css']
})
export class ServersComponent {
  serverId:number = 1001
  serverStatus:string = 'Offline'
  getServerId(){
    return this.serverId;
  }
  getServerStatus(){
    return this.serverStatus;
  }
  addNewServer:boolean =false
  serverCreated: string = "Not yet"
  constructor()
  {
    setTimeout(() =>{
    this.addNewServer = true;
    }, 5000);
  }
  onServerCreation(){
    this.serverCreated = "Created";
    this.serverList.push(this.serverName)

  }
  serverName=""
  onServerNameEntry(event : Event)
  {
    console.log(event.target);
    this.serverName= (<HTMLInputElement>event.target).value;
  }
  PushData(){
    this.serverList.push(this.serverName)
  }
  serverList = ['SQL','Oracle'];
}
