import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PtcodesComponent } from './ptcodes.component';

describe('PtcodesComponent', () => {
  let component: PtcodesComponent;
  let fixture: ComponentFixture<PtcodesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PtcodesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PtcodesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
