import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GtablesComponent } from './gtables.component';

describe('GtablesComponent', () => {
  let component: GtablesComponent;
  let fixture: ComponentFixture<GtablesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GtablesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GtablesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
