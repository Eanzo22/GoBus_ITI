import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IResponse } from '../../models/iresponse';
import { IUserRead } from '../../models/user/iuser-read';
import { AdminService } from '../../services/admin/admin.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss'],
})
export class HeaderComponent implements OnInit {
  admin: IUserRead = {} as IUserRead;

  constructor(
    private router: Router,
    private adminService: AdminService,
    private _activatedRoute: ActivatedRoute
  ) {
    this._activatedRoute.paramMap.subscribe((params) => {
      this.ngOnInit();
    });
  }

  ngOnInit(): void {
    this.GetAdmin();
  }
  GetAdmin() {
    //  if(this.isAdminLogged){
    this.adminService.GetAdmin().subscribe({
      next: (v) => {
        let response = v as IResponse;
        this.admin = response.data as IUserRead;
      },
      // error: (e) => {},
      // complete: () => console.log('complete'),
    });
  // }
}
  LogOut() {
    this.router.navigate(['/login']);
    this.admin = {} as IUserRead;
    localStorage.removeItem('token');
    sessionStorage.removeItem('token');
  }

  get isAdminLogged(): boolean {
    if(localStorage.getItem('token'))
    return localStorage.getItem('token') ? true : false;
  else if(sessionStorage.getItem('token'))
    return sessionStorage.getItem('token') ? true : false;
  else
    return false;
  }
}
