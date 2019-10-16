import { Injectable } from '@angular/core';
import { UserDetail } from '../../models/UserDetail';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UserService {
    apiUrl: string = 'api/user/signup'
    constructor(private http: HttpClient) { }
    authenticateToken(token: string): boolean {
        return true;

    }
    authenticateUser(user: UserDetail) {

    }
    createUser(user: UserDetail): { userCreated: boolean, errorMsg: string } {
        let userCreated: boolean = false;
        let errorMsg: string;
        this.http.post(this.apiUrl, user, { observe: 'response' }).subscribe(response => {
            if (response.status !== 201) {
                errorMsg = response.body["message"];
            }
            else {
                userCreated = true;
            }
        });
        return  { userCreated, errorMsg };
    }

}
