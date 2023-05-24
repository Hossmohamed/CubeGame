import { TestBed } from '@angular/core/testing';

import { MostpopularService } from './mostpopular.service';

describe('MostpopularService', () => {
  let service: MostpopularService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MostpopularService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
