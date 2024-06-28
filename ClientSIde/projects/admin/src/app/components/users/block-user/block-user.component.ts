import { Component, OnInit, Inject } from '@angular/core';
import { UserService } from '../../../services/user/user.service';
import { ToastrService } from 'ngx-toastr';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { IResponse } from '../../../models/iresponse';
import { IUserRead } from '../../../models/user/iuser-read';

@Component({
  selector: 'app-block-user',
  templateUrl: './block-user.component.html',
  styleUrls: ['./block-user.component.scss'],
})
export class BlockUserComponent implements OnInit {
  constructor(
    private userService: UserService,
    private toastr: ToastrService,
    public dialog: MatDialogRef<BlockUserComponent>,
    @Inject(MAT_DIALOG_DATA) public data: IUserRead
  ) {}
  ngOnInit(): void {}
  Block() {
    this.userService.BlockUser(this.data.id).subscribe({
      next: (v) => {
        let response = v as IResponse;
        this.toastr.success(response.messages.toString());
        this.dialog.close(true);
      },
      // error: (e) => console.log(e),
      // complete: () => console.log('complete'),
    });
  }
}
