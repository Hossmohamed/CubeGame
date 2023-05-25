import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GameonsaleComponent } from './gameonsale.component';

describe('GameonsaleComponent', () => {
  let component: GameonsaleComponent;
  let fixture: ComponentFixture<GameonsaleComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [GameonsaleComponent]
    });
    fixture = TestBed.createComponent(GameonsaleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
