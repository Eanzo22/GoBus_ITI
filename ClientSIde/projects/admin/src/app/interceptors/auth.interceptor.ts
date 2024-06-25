import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
} from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class AuthInterceptor implements HttpInterceptor {
  constructor() {}

  intercept(
    request: HttpRequest<unknown>,
    next: HttpHandler
  ): Observable<HttpEvent<unknown>> {
    let token;
    if(localStorage.getItem('token'))
      token=localStorage.getItem('token');
    else
      token=sessionStorage.getItem('token');
    const newRequest = request.clone({
      headers: request.headers.append(
        'Authorization',
        `Bearer ` + token
      ),
    });

    return next.handle(newRequest);
  }
}
