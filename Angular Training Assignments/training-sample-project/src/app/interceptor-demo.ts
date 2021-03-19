import { Injectable } from "@angular/core";
import { HttpInterceptor, HttpRequest, HttpHandler, HttpEvent} from "@angular/common/http";
import { Observable } from 'rxjs';

@Injectable()
export class InterceptorDemo implements HttpInterceptor {
    intercept(req: HttpRequest<any>, next: HttpHandler ) : Observable<HttpEvent<any>> {
        
        let token = sessionStorage.getItem('token');
         const modireq = req.clone({
             headers: req.headers.set('Content-Type', 'json'),

         });

         req = req.clone({
             headers: req.headers.append('Authorization', 'Bearear-' + token),
         });
        
        return next.handle(req);
    }
}
