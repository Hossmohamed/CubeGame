import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddCategoryDashboardComponent } from './add-category-dashboard.component';

describe('AddCategoryDashboardComponent', () => {
  let component: AddCategoryDashboardComponent;
  let fixture: ComponentFixture<AddCategoryDashboardComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AddCategoryDashboardComponent]
    });
    fixture = TestBed.createComponent(AddCategoryDashboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
