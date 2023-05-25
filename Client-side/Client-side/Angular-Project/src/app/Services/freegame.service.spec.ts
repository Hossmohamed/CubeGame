import { TestBed } from '@angular/core/testing';

import { FreegameService } from './freegame.service';

describe('FreegameService', () => {
  let service: FreegameService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(FreegameService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
