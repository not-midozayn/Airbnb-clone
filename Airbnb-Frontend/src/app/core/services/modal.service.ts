import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ModalService {
  private loginModalSubject = new BehaviorSubject<boolean>(false);
  loginModal$ = this.loginModalSubject.asObservable();

  openLoginModal() {
    this.loginModalSubject.next(true);
    document.body.style.overflow = 'hidden';
  }

  closeLoginModal() {
    this.loginModalSubject.next(false);
    document.body.style.overflow = '';
  }

}
