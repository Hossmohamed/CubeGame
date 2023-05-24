import { TestBed } from '@angular/core/testing';

import { MainsliderService } from './mainslider.service';

describe('MainsliderService', () => {
  let service: MainsliderService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MainsliderService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
