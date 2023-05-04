import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BcodesComponent } from './bcodes.component';

describe('BcodesComponent', () => {
  let component: BcodesComponent;
  let fixture: ComponentFixture<BcodesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BcodesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BcodesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
