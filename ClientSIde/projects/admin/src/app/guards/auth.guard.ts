import { Injectable } from '@angular/core';
import { CanActivate, Router, UrlTree } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class AuthGuard implements CanActivate {
  constructor(private routService: Router,private toastr:ToastrService ) {}

  canActivate():
    | Observable<boolean | UrlTree>
    | Promise<boolean | UrlTree>
    | boolean
    | UrlTree {
    if (localStorage.getItem('token') || sessionStorage.getItem('token')) {
      return true;
    }
    else {
      this.toastr.error('You are not authorized to access this page. Please log in.');
      this.routService.navigate(['/login']);
      return false;
    }
  }
}
