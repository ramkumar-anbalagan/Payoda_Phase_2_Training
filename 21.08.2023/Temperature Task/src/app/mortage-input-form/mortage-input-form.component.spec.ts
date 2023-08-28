import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MortageInputFormComponent } from './mortage-input-form.component';

describe('MortageInputFormComponent', () => {
  let component: MortageInputFormComponent;
  let fixture: ComponentFixture<MortageInputFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MortageInputFormComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MortageInputFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
