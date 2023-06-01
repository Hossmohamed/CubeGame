import { TestBed } from '@angular/core/testing';

import { GameonsalesService } from './gameonsales.service';

describe('GameonsalesService', () => {
  let service: GameonsalesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GameonsalesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
