import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ComputepayComponent } from './computepay.component';

describe('ComputepayComponent', () => {
  let component: ComputepayComponent;
  let fixture: ComponentFixture<ComputepayComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ComputepayComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ComputepayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
