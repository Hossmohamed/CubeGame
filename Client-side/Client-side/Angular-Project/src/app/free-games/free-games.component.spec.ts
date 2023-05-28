import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FreeGamesComponent } from './free-games.component';

describe('FreeGamesComponent', () => {
  let component: FreeGamesComponent;
  let fixture: ComponentFixture<FreeGamesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [FreeGamesComponent]
    });
    fixture = TestBed.createComponent(FreeGamesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
