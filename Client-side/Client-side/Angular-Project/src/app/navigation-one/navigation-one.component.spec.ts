import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NavigationOneComponent } from './navigation-one.component';

describe('NavigationOneComponent', () => {
  let component: NavigationOneComponent;
  let fixture: ComponentFixture<NavigationOneComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [NavigationOneComponent]
    });
    fixture = TestBed.createComponent(NavigationOneComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
