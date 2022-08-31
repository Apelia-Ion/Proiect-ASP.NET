import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { RecipesComponent } from './recipes/recipes.component';
import { FormsModule } from '@angular/forms';
import { MessagesComponent } from './messages/messages.component';
import { AppRoutingModule } from './app-routing.module';
import { ChefsComponent } from './chefs/chefs.component';
import { WelcomePageComponent } from './welcome-page/welcome-page.component';
import { RecipeDetailsComponent } from './recipe-details/recipe-details.component'; // <-- NgModel lives here
import { HttpClientModule } from '@angular/common/http';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';


@NgModule({
  declarations: [
    AppComponent,
    RecipesComponent,
    MessagesComponent,
    ChefsComponent,
    WelcomePageComponent,
    RecipeDetailsComponent,
    RegisterComponent,
    LoginComponent
   
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
