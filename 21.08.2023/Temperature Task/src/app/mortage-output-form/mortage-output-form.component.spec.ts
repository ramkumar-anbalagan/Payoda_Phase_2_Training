import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MortageOutputFormComponent } from './mortage-output-form.component';

describe('MortageOutputFormComponent', () => {
  let component: MortageOutputFormComponent;
  let fixture: ComponentFixture<MortageOutputFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MortageOutputFormComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MortageOutputFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
