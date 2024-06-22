import { Component, OnInit, Inject } from '@angular/core';
import { PublicActivityService } from '../../../services/publicActivity/public-activity.service';
import { ToastrService } from 'ngx-toastr';
import { DeleteDestinationComponent } from '../../destinations/delete-destination/delete-destination.component';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { IResponse } from '../../../models/iresponse';
import { IPublicActivity } from 'projects/user/src/app/models/ipublic-activity';

@Component({
  selector: 'app-delete-public-activity',
  templateUrl: './delete-public-activity.component.html',
  styleUrls: ['./delete-public-activity.component.scss'],
})
export class DeletePublicActivityComponent implements OnInit {
  activityName:string;
  constructor(
    private publicActivityService: PublicActivityService,
    private toastr: ToastrService,
    public dialog: MatDialogRef<DeleteDestinationComponent>,
    @Inject(MAT_DIALOG_DATA) public data: IPublicActivity
  ) {
    this.activityName = data.title;
  }
  ngOnInit(): void {}
  Delete() {
    this.publicActivityService.DeletePublicActivity(this.data.id).subscribe({
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
