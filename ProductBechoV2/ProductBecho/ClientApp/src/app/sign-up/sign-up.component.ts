import { Component, OnInit } from '@angular/core';
import { UserDetail } from '../models/UserDetail';
import { UserService } from '../services/UserService/user.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {
    userDetail: UserDetail = new UserDetail();
    errorMessage: string;
    constructor(private userService: UserService, private router: Router) { }

    ngOnInit() {
    }
    signUpUser() {
        const respObj = this.userService.createUser(this.userDetail);
        if (respObj.userCreated) {
            this.router.navigate(['/signin']);
        }
        else {
            this.errorMessage = respObj.errorMsg;
        }
    }

}
