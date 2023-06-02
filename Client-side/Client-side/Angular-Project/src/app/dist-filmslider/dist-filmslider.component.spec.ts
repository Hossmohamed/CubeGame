import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DistFilmsliderComponent } from './dist-filmslider.component';

describe('DistFilmsliderComponent', () => {
  let component: DistFilmsliderComponent;
  let fixture: ComponentFixture<DistFilmsliderComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DistFilmsliderComponent]
    });
    fixture = TestBed.createComponent(DistFilmsliderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
