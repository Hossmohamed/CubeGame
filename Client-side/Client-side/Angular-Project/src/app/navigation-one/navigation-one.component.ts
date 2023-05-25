import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from 'src/Services/auth.service';
import { UserStoreService } from 'src/Services/user-store.service';

@Component({
  selector: 'app-navigation-one',
  templateUrl: './navigation-one.component.html',
  styleUrls: ['./navigation-one.component.css']
})
export class NavigationOneComponent implements OnInit{

  public fullName:string =""
  public role:string =""

  Logged:boolean = false
  constructor(private user_Store: UserStoreService , private auth : AuthService , private route:Router){}
  ngOnInit(): void {

    if(this.auth.IsLoggedIn()){
      this.Logged = true
    }
    this.user_Store.getFullNameFromStore().subscribe({
      next:(data)=>{

        let fullnameFromToken = this.auth.getFullNameFromToken();
        this.fullName = data || fullnameFromToken
      }
    })

    // this.user_Store.getRoleFromStore().subscribe({
    //   next:(data)=>{

    //     let fullRoleFromToken = this.auth.getRoleFromToken();
    //     this.role = data || fullRoleFromToken

    //   }
    // })
  }

  logOut(){
    this.auth.logOut();
    this.route.navigate(['Browse'])
    window.location.reload()
  }
}
