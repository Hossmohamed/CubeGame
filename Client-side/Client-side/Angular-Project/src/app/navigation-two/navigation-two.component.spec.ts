import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NavigationTwoComponent } from './navigation-two.component';

describe('NavigationTwoComponent', () => {
  let component: NavigationTwoComponent;
  let fixture: ComponentFixture<NavigationTwoComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [NavigationTwoComponent]
    });
    fixture = TestBed.createComponent(NavigationTwoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
