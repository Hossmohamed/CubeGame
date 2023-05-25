import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FreegameComponent } from './freegame.component';

describe('FreegameComponent', () => {
  let component: FreegameComponent;
  let fixture: ComponentFixture<FreegameComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [FreegameComponent]
    });
    fixture = TestBed.createComponent(FreegameComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
