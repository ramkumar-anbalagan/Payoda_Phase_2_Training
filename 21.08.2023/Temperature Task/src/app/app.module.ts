import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { ConverterComponent } from './converter/converter.component';
import { MortageInputFormComponent } from './mortage-input-form/mortage-input-form.component';
import { MortageOutputFormComponent } from './mortage-output-form/mortage-output-form.component';

@NgModule({
  declarations: [
    AppComponent,
    ConverterComponent,
    MortageInputFormComponent,
    MortageOutputFormComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
