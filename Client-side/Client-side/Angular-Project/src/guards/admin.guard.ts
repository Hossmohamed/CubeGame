import { Injectable, Injector } from '@angular/core';
import { CanActivate, CanActivateFn, Router } from '@angular/router';
import { AuthService } from 'src/Services/auth.service';

// export const adminGuard: CanActivateFn = (route, state) => {
//   return true;
// };

@Injectable({
  providedIn: 'root'
})
export class adminGuard implements CanActivate {
  constructor(private injector: Injector, private router: Router){};
  canActivate(
   ): boolean {
    let isLoggedIn = this.injector.get(AuthService).IsLoggedIn();
    if (isLoggedIn && this.injector.get(AuthService).getRoleFromToken()==='Admin'){
      return true
    } else {
      this.router.navigate(['/']);
      return false;
    }
  }

}
