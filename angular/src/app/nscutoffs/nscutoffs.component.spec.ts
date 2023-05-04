import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NscutoffsComponent } from './nscutoffs.component';

describe('NscutoffsComponent', () => {
  let component: NscutoffsComponent;
  let fixture: ComponentFixture<NscutoffsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NscutoffsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NscutoffsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
