import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GameonsalesComponent } from './gameonsales.component';

describe('GameonsalesComponent', () => {
  let component: GameonsalesComponent;
  let fixture: ComponentFixture<GameonsalesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [GameonsalesComponent]
    });
    fixture = TestBed.createComponent(GameonsalesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
