import { Component, Input } from '@angular/core';
import { FormControl } from '@angular/forms';
import { MatListModule } from '@angular/material/list';
@Component({
  selector: 'app-password-requirements',
  templateUrl: './password-requirements.component.html',
  styleUrls: ['./password-requirements.component.scss']
})
export class PasswordRequirementsComponent {
  @Input() passwordControl!: FormControl;

  get requirements() {
    const value = this.passwordControl.value || '';
    return [
      { label: 'At least 8 characters', valid: value.length >= 8 },
      { label: 'At least one uppercase letter', valid: /[A-Z]/.test(value) },
      { label: 'At least one lowercase letter', valid: /[a-z]/.test(value) },
      { label: 'At least one number', valid: /[0-9]/.test(value) },
      { label: 'At least one special character', valid: /[#!@$%^&*-_]/.test(value) },
    ];
  }
}
