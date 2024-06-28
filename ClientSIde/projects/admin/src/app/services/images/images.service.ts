import { Injectable } from '@angular/core';
import { DomSanitizer, SafeUrl } from '@angular/platform-browser';
import {environment} from '../../environments/environment';
@Injectable({
  providedIn: 'root'
})
export class ImagesService {

  constructor(private sanitizer: DomSanitizer) { }
  getImageUrl(imagePath: string) :SafeUrl {
    // return `../../../assets${imagePath}`;
    let safeurl = environment.Api + '/' + imagePath ;

    // console.log(safeurl);

    return  this.sanitizer.bypassSecurityTrustUrl(safeurl) ;

  }
}
