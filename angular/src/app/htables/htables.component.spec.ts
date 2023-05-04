import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HtablesComponent } from './htables.component';

describe('HtablesComponent', () => {
  let component: HtablesComponent;
  let fixture: ComponentFixture<HtablesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HtablesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HtablesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
