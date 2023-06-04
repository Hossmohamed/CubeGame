import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DistFilmslidelComponent } from './dist-filmslidel.component';

describe('DistFilmslidelComponent', () => {
  let component: DistFilmslidelComponent;
  let fixture: ComponentFixture<DistFilmslidelComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DistFilmslidelComponent]
    });
    fixture = TestBed.createComponent(DistFilmslidelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
