import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpErrorResponse,
} from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';

@Injectable()
export class ErrorInterceptor implements HttpInterceptor {
  constructor(private toaster: ToastrService, private router: Router) {}

  intercept(
    request: HttpRequest<unknown>,
    next: HttpHandler
  ): Observable<HttpEvent<unknown>> {
    return next.handle(request).pipe(
      catchError((error: HttpErrorResponse) => {
        if (error.status === 401) {
          this.toaster.error('Not Authorized');
          this.router.navigate(['/login']);
          localStorage.removeItem('token');
          sessionStorage.removeItem('token');
        } else if (error.status === 0) {
          this.toaster.error('Server is not working');
        } else {
          this.toaster.error(error.error.messages || 'An error occurred');
        }
        return throwError(error);
      })
    );
  }
}
