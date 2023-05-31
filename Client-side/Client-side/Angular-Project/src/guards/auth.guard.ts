// import { CanActivateFn } from '@angular/router';

// export const authGuard: CanActivateFn = (route, state) => {
//   return true;
// };


import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router} from '@angular/router';
import { Observable } from 'rxjs';

import { Injectable } from '@angular/core';
import { AuthService } from 'src/Services/auth.service';
@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(private authService:AuthService, private router: Router, state: RouterStateSnapshot){};
  canActivate(
    next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): boolean {
    let isLoggedIn = this.authService.IsLoggedIn();
    if (isLoggedIn){
      return true
    } else {
      this.router.navigate(['/Login']);
      return false;
    }
  }

}
