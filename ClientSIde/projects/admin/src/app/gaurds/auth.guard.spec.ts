import { TestBed } from '@angular/core/testing';
import { Router } from '@angular/router';
import { AuthGuard } from './auth.guard';
import { RouterTestingModule } from '@angular/router/testing';

describe('AuthGuard', () => {
  let authGuard: AuthGuard;
  let router: Router;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [RouterTestingModule.withRoutes([])],
      providers: [AuthGuard],
    });

    authGuard = TestBed.inject(AuthGuard);
    router = TestBed.inject(Router);

    spyOn(router, 'navigate');
  });

  it('should be created', () => {
    expect(authGuard).toBeTruthy();
  });

  it('should allow the authenticated user to access app', () => {
    spyOn(localStorage, 'getItem').and.returnValue('valid-token');
    expect(authGuard.canActivate()).toBeTrue();
  });

  it('should navigate to login for unauthenticated user', () => {
    spyOn(localStorage, 'getItem').and.returnValue(null);
    expect(authGuard.canActivate()).toBeFalse();
    expect(router.navigate).toHaveBeenCalledWith(['/login']);
  });
});

// import { TestBed } from '@angular/core/testing';
// import { CanActivateFn } from '@angular/router';

// import { authGuard } from './auth.guard';

// describe('authGuard', () => {
//   const executeGuard: CanActivateFn = (...guardParameters) =>
//       TestBed.runInInjectionContext(() => authGuard(...guardParameters));

//   beforeEach(() => {
//     TestBed.configureTestingModule({});
//   });

//   it('should be created', () => {
//     expect(executeGuard).toBeTruthy();
//   });
// });
