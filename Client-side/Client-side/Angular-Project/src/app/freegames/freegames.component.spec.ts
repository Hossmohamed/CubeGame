import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FreegamesComponent } from './freegames.component';

describe('FreegamesComponent', () => {
  let component: FreegamesComponent;
  let fixture: ComponentFixture<FreegamesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [FreegamesComponent]
    });
    fixture = TestBed.createComponent(FreegamesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
