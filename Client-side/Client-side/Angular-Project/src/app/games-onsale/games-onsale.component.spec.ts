import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GamesOnsaleComponent } from './games-onsale.component';

describe('GamesOnsaleComponent', () => {
  let component: GamesOnsaleComponent;
  let fixture: ComponentFixture<GamesOnsaleComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [GamesOnsaleComponent]
    });
    fixture = TestBed.createComponent(GamesOnsaleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
