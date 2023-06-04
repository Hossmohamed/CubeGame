import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateCategoryDashboardComponent } from './update-category-dashboard.component';

describe('UpdateCategoryDashboardComponent', () => {
  let component: UpdateCategoryDashboardComponent;
  let fixture: ComponentFixture<UpdateCategoryDashboardComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UpdateCategoryDashboardComponent]
    });
    fixture = TestBed.createComponent(UpdateCategoryDashboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
