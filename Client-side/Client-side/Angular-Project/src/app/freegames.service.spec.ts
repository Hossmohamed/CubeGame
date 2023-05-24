import { TestBed } from '@angular/core/testing';

import { FreegamesService } from './freegames.service';

describe('FreegamesService', () => {
  let service: FreegamesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(FreegamesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
