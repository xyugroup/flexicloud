import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ClosepayComponent } from './closepay.component';

describe('ClosepayComponent', () => {
  let component: ClosepayComponent;
  let fixture: ComponentFixture<ClosepayComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ClosepayComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ClosepayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
