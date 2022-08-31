import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RecipesComponent  } from './recipes/recipes.component';
import { ChefsComponent } from './chefs/chefs.component';
import { WelcomePageComponent } from './welcome-page/welcome-page.component';
import { RecipeDetailsComponent} from './recipe-details/recipe-details.component';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import { AuthGuard } from './auth.guard';

const routes: Routes = [
  //am adaugat un guard pe Chefs
  {path:'', canActivate:[AuthGuard],
  children: [
    {path:'chefs',component: ChefsComponent}
  ]},
  {path: '', redirectTo: 'Welcome', pathMatch: 'full' },
  {path:'Welcome', component: WelcomePageComponent},
  {path: 'recipes', component: RecipesComponent },
   //{path:'chefs',component: ChefsComponent},
  //{path: 'register', component: RegisterComponent},
  //{path:'login', component: LoginComponent},
  { path: 'details/:id', component: RecipeDetailsComponent },
  {
  path:'reviews', 
  loadChildren: () => import ('src/app/Modules/reviews/reviews.module').then(n => n.ReviewsModule)
  },
  {
  path:'login', 
  loadChildren: () => import ('src/app/Modules/authentication/authentication.module').then(n => n.AuthenticationModule)
  },
  {
  path:'register', 
  loadChildren: () => import ('src/app/Modules/authentication/authentication.module').then(n => n.AuthenticationModule)
  }


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }