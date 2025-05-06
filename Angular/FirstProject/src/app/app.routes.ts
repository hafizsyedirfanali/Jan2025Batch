import { Routes } from '@angular/router';
import { LayoutComponent } from './layout/layout.component';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';
import { PrivacyComponent } from './privacy/privacy.component';
import { InterpolationComponent } from './binding/interpolation/interpolation.component';

export const routes: Routes = [
    { path: 'layout', component: LayoutComponent },
    { path: 'about', component: AboutComponent },
    { path: 'contact', component: ContactComponent },
    { path: 'privacy', component: PrivacyComponent },
    { path: 'interpolation', component: InterpolationComponent },
];
