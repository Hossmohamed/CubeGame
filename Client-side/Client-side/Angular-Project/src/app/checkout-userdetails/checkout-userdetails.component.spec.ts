import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CheckoutUserdetailsComponent } from './checkout-userdetails.component';

describe('CheckoutUserdetailsComponent', () => {
  let component: CheckoutUserdetailsComponent;
  let fixture: ComponentFixture<CheckoutUserdetailsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CheckoutUserdetailsComponent]
    });
    fixture = TestBed.createComponent(CheckoutUserdetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
