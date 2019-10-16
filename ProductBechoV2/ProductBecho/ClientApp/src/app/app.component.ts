import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from './services/UserService/user.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
    userExists: boolean = false;
    constructor(private router: Router, private userService: UserService) { }
    ngOnInit() {
        const tokenId = window.localStorage["token_id"] ? JSON.parse(window.localStorage["token_id"]) : null;
        if (!tokenId) {
            this.router.navigate(['/signup']);
        }
        if (!this.userService.authenticateToken(tokenId)) {
            this.router.navigate(['/signup']);
        }
    }
}
