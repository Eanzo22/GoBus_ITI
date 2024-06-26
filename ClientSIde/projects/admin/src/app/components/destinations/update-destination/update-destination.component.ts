import { Component, Inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { DestinationService } from '../../../services/destination/destination.service';
import { ToastrService } from 'ngx-toastr';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { IDestinationRead } from '../../../models/destination/idestination-read';
import { IResponse } from '../../../models/iresponse';

@Component({
  selector: 'app-update-destination',
  templateUrl: './update-destination.component.html',
  styleUrls: ['./update-destination.component.scss'],
})
export class UpdateDestinationComponent {
  destinationForm: FormGroup;
  selectedFile!: File;
  constructor(
    private fb: FormBuilder,
    private destinationService: DestinationService,
    private toastr: ToastrService,
    public dialog: MatDialogRef<UpdateDestinationComponent>,
    @Inject(MAT_DIALOG_DATA) public data: IDestinationRead
  ) {
    this.destinationForm = this.fb.group({
      name: [
        data.name,
        [Validators.required, Validators.pattern('[A-Za-z0-9_ ]{3,}')],
      ],
      imageURL: [data.imageURL, [Validators.required]],
    });
  }
  ngOnInit(): void {}

  SelectImage(event: any) {
    this.selectedFile = event.target.files[0];
  }

  Update() {
    let formData = new FormData();

      formData.append('imageURL', this.imageURL?.value);
      formData.append('name', this.name?.value);
    // console.log(this.selectedFile)
    if (this.selectedFile) {
      formData.append('file', this.selectedFile);
    }
    //  else {
    // console.log(this.imageURL?.value)
    // }

    this.destinationService
      .UpdateDestination(this.data.id, formData)
      .subscribe({
        next: (v) => {
          let response = v as IResponse;
          this.toastr.success(response.messages.toString());
          this.dialog.close(true);
        },
        // error: (e) => console.log(e),
        // complete: () => console.log('complete'),
      });
  }

  get name() {
    return this.destinationForm.get('name');
  }
  get imageURL() {
    return this.destinationForm.get('imageURL');
  }
}
