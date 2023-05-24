import { TestBed } from '@angular/core/testing';

import { GameonsaleService } from './gameonsale.service';

describe('GameonsaleService', () => {
  let service: GameonsaleService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GameonsaleService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
