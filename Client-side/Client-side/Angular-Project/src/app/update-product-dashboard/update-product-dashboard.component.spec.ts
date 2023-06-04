import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateProductDashboardComponent } from './update-product-dashboard.component';

describe('UpdateProductDashboardComponent', () => {
  let component: UpdateProductDashboardComponent;
  let fixture: ComponentFixture<UpdateProductDashboardComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UpdateProductDashboardComponent]
    });
    fixture = TestBed.createComponent(UpdateProductDashboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
